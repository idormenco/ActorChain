import { Transaction } from './../blockchain-view/blockchain-view.component';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-transaction-view',
  templateUrl: './transaction-view.component.html',
  styleUrls: ['./transaction-view.component.scss']
})
export class TransactionViewComponent implements OnInit {
  transactions: Transaction[] = [
    {
      sender: 'ion',
      receiver: 'vasile',
      amount: 7
    },
    {
      sender: 'ion',
      receiver: 'vasile',
      amount: 6
    },
    {
      sender: 'ion',
      receiver: 'vasile',
      amount: 5
    },
    {
      sender: 'ion',
      receiver: 'vasile',
      amount: 4
    },
    {
      sender: 'ion',
      receiver: 'vasile',
      amount: 3
    },
  ];
  constructor() { }

  ngOnInit() {
  }

}
