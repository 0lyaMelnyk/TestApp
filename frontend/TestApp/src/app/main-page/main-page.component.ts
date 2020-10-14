import { Component, OnInit } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';
import {Transaction} from '../Models/Transaction';
@Component({
  selector: 'app-main-page',
  templateUrl: './main-page.component.html',
  styleUrls: ['./main-page.component.css']
})
export class MainPageComponent implements OnInit {

  transactionList: Transaction[] = [{
    id: 1,
    status: 'pending',
    type: 'Refil',
    clientName: 'Bulkin Ivan',
    amount: 100.00
  },
  {
    id: 2,
    status: 'pending',
    type: 'Refil',
    clientName: 'Bulkin Ivan',
    amount: 100.00
  },
  {
    id: 2,
    status: 'pending',
    type: 'Refil',
    clientName: 'Bulkin Ivan',
    amount: 100.00
  },
  {
    id: 2,
    status: 'pending',
    type: 'Refil',
    clientName: 'Bulkin Ivan',
    amount: 100.00
  },
  {
    id: 2,
    status: 'pending',
    type: 'Refil',
    clientName: 'Bulkin Ivan',
    amount: 100.00
  },
  {
    id: 2,
    status: 'pending',
    type: 'Refil',
    clientName: 'Bulkin Ivan',
    amount: 100.00
  },
  {
    id: 2,
    status: 'pending',
    type: 'Refil',
    clientName: 'Bulkin Ivan',
    amount: 100.00
  },
  {
    id: 2,
    status: 'pending',
    type: 'Refil',
    clientName: 'Bulkin Ivan',
    amount: 100.00
  },
  {
    id: 2,
    status: 'pending',
    type: 'Refil',
    clientName: 'Bulkin Ivan',
    amount: 100.00
  }];
  displayedColumns = ['id', 'status', 'type', 'clientName', 'amount'];
  dataSource = new MatTableDataSource<Transaction>(this.transactionList);
  constructor() {
  }

  ngOnInit(): void {
  }

}
