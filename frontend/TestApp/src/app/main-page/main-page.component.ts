import { Component, OnInit } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';
import {Transaction} from '../Models/Transaction';
import {HttpService} from '../core/http.service';
import { Observable } from 'rxjs';
import { TransactionStatus } from '../Models/TransactionStatus';
import {DisplayTransaction} from '../Models/DisplayTransaction';
import { ExportToCsv } from 'export-to-csv';
import { NgxCsvParser } from 'ngx-csv-parser';

@Component({
  selector: 'app-main-page',
  templateUrl: './main-page.component.html',
  styleUrls: ['./main-page.component.css']
})
export class MainPageComponent implements OnInit {

  transactionList: Transaction[];
  displayedColumns = ['id', 'status', 'type', 'clientName', 'amount', 'actions'];
  dataSource;
  displayTransactions: DisplayTransaction[];
  map = new Map();
  selectedStatus: string;
  selectedType: string;
  options = {
    fieldSeparator: ',',
    quoteStrings: '"',
    decimalSeparator: '.',
    showLabels: true,
    showTitle: true,
    title: 'My Awesome CSV',
    useTextFile: false,
    useBom: true,
    useKeysAsHeaders: true,
    // headers: ['Column 1', 'Column 2', etc...] <-- Won't work with useKeysAsHeaders present!
  };
  constructor(private httpService: HttpService, private ngxCsvParser: NgxCsvParser) {
  }

  ngOnInit(): void {
    this.getTransactions().subscribe(x => {
      this.transactionList = x;
      this.transactionList.map(y => {y.status = TransactionStatus[y.status];
        console.log(typeof(TransactionStatus[y.status]));
           return y;});
      this.dataSource = new MatTableDataSource<Transaction>(x);
    });
  }

  //(x=>x.map(x=>{
  //  x.status = Transaction[this.x.status];
   // retunr x;
  //}))


  getTransactions(): Observable<Transaction[]>{
    return this.httpService.getRequest<Transaction[]>
    ('https://localhost:44365/api/transactions');
  }
  export_click(): void{
    const csvExporter = new ExportToCsv(this.options);
    csvExporter.generateCsv(this.transactionList);
  }
}
