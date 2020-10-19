import {TransactionStatus} from '../Models/TransactionStatus';
import {TransactionType} from '../Models/TransactionType';
export interface Transaction{
    id: number;
    status: string;
    type: TransactionType;
    clientName: string;
    amount: number;
}
