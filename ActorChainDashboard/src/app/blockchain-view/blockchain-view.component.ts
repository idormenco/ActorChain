import { Component, OnInit } from '@angular/core';
export interface Transaction {
  sender: string;
  receiver: string;
  amount: number;
}
export interface Block {
  hash: string;
  previousHash?: string;
  nonce: number;
  timestamp: number;
  transactions?: Transaction[];
}

@Component({
  selector: 'app-blockchain-view',
  templateUrl: './blockchain-view.component.html',
  styleUrls: ['./blockchain-view.component.scss']
})
export class BlockchainViewComponent implements OnInit {


  blockchain: Block[] = [];

  constructor() {
    this.blockchain = [
      {
        hash: 'hash1',
        timestamp: 12222,
        nonce: 0,
      },
      {
        hash: 'hash2',
        timestamp: 13333,
        nonce: 1,
        previousHash: 'hash1',
        transactions: [
          {
            amount: 1,
            receiver: 'ion',
            sender: 'ion2'
          },
          {
            amount: 2,
            receiver: 'ion',
            sender: 'ion3'
          },
          {
            amount: 1,
            receiver: 'ion',
            sender: 'ion2'
          },
          {
            amount: 2,
            receiver: 'ion',
            sender: 'ion3'
          },
          {
            amount: 1,
            receiver: 'ion',
            sender: 'ion2'
          },
          {
            amount: 2,
            receiver: 'ion',
            sender: 'ion3'
          },
          {
            amount: 1,
            receiver: 'ion',
            sender: 'ion2'
          },
          {
            amount: 2,
            receiver: 'ion',
            sender: 'ion3'
          },
        ]
      },
      {
        hash: 'hash2',
        timestamp: 13333,
        nonce: 1,
        previousHash: 'hash1',
        transactions: [
          {
            amount: 1,
            receiver: 'ion',
            sender: 'ion2'
          },
          {
            amount: 2,
            receiver: 'ion',
            sender: 'ion3'
          },
          {
            amount: 1,
            receiver: 'ion',
            sender: 'ion2'
          },
          {
            amount: 2,
            receiver: 'ion',
            sender: 'ion3'
          },
          {
            amount: 1,
            receiver: 'ion',
            sender: 'ion2'
          },
          {
            amount: 2,
            receiver: 'ion',
            sender: 'ion3'
          },
          {
            amount: 1,
            receiver: 'ion',
            sender: 'ion2'
          },
          {
            amount: 2,
            receiver: 'ion',
            sender: 'ion3'
          },
        ]
      },
      {
        hash: 'hash2',
        timestamp: 13333,
        nonce: 1,
        previousHash: 'hash1',
        transactions: [
          {
            amount: 1,
            receiver: 'ion',
            sender: 'ion2'
          },
          {
            amount: 2,
            receiver: 'ion',
            sender: 'ion3'
          },
          {
            amount: 1,
            receiver: 'ion',
            sender: 'ion2'
          },
          {
            amount: 2,
            receiver: 'ion',
            sender: 'ion3'
          },
          {
            amount: 1,
            receiver: 'ion',
            sender: 'ion2'
          },
          {
            amount: 2,
            receiver: 'ion',
            sender: 'ion3'
          },
          {
            amount: 1,
            receiver: 'ion',
            sender: 'ion2'
          },
          {
            amount: 2,
            receiver: 'ion',
            sender: 'ion3'
          },
        ]
      },
      {
        hash: 'hash2',
        timestamp: 13333,
        nonce: 1,
        previousHash: 'hash1',
        transactions: [
          {
            amount: 1,
            receiver: 'ion',
            sender: 'ion2'
          },
          {
            amount: 2,
            receiver: 'ion',
            sender: 'ion3'
          },
          {
            amount: 1,
            receiver: 'ion',
            sender: 'ion2'
          },
          {
            amount: 2,
            receiver: 'ion',
            sender: 'ion3'
          },
          {
            amount: 1,
            receiver: 'ion',
            sender: 'ion2'
          },
          {
            amount: 2,
            receiver: 'ion',
            sender: 'ion3'
          },
          {
            amount: 1,
            receiver: 'ion',
            sender: 'ion2'
          },
          {
            amount: 2,
            receiver: 'ion',
            sender: 'ion3'
          },
        ]
      },
      {
        hash: 'hash2',
        timestamp: 13333,
        nonce: 1,
        previousHash: 'hash1',
        transactions: [
          {
            amount: 1,
            receiver: 'ion',
            sender: 'ion2'
          },
          {
            amount: 2,
            receiver: 'ion',
            sender: 'ion3'
          },
          {
            amount: 1,
            receiver: 'ion',
            sender: 'ion2'
          },
          {
            amount: 2,
            receiver: 'ion',
            sender: 'ion3'
          },
          {
            amount: 1,
            receiver: 'ion',
            sender: 'ion2'
          },
          {
            amount: 2,
            receiver: 'ion',
            sender: 'ion3'
          },
          {
            amount: 1,
            receiver: 'ion',
            sender: 'ion2'
          },
          {
            amount: 2,
            receiver: 'ion',
            sender: 'ion3'
          },
        ]
      },
      {
        hash: 'hash2',
        timestamp: 13333,
        nonce: 1,
        previousHash: 'hash1',
        transactions: [
          {
            amount: 1,
            receiver: 'ion',
            sender: 'ion2'
          },
          {
            amount: 2,
            receiver: 'ion',
            sender: 'ion3'
          },
          {
            amount: 1,
            receiver: 'ion',
            sender: 'ion2'
          },
          {
            amount: 2,
            receiver: 'ion',
            sender: 'ion3'
          },
          {
            amount: 1,
            receiver: 'ion',
            sender: 'ion2'
          },
          {
            amount: 2,
            receiver: 'ion',
            sender: 'ion3'
          },
          {
            amount: 1,
            receiver: 'ion',
            sender: 'ion2'
          },
          {
            amount: 2,
            receiver: 'ion',
            sender: 'ion3'
          },
        ]
      },
      {
        hash: 'hash2',
        timestamp: 13333,
        nonce: 1,
        previousHash: 'hash1',
        transactions: [
          {
            amount: 1,
            receiver: 'ion',
            sender: 'ion2'
          },
          {
            amount: 2,
            receiver: 'ion',
            sender: 'ion3'
          },
          {
            amount: 1,
            receiver: 'ion',
            sender: 'ion2'
          },
          {
            amount: 2,
            receiver: 'ion',
            sender: 'ion3'
          },
          {
            amount: 1,
            receiver: 'ion',
            sender: 'ion2'
          },
          {
            amount: 2,
            receiver: 'ion',
            sender: 'ion3'
          },
          {
            amount: 1,
            receiver: 'ion',
            sender: 'ion2'
          },
          {
            amount: 2,
            receiver: 'ion',
            sender: 'ion3'
          },
        ]
      },
      {
        hash: 'hash2',
        timestamp: 13333,
        nonce: 1,
        previousHash: 'hash1',
        transactions: [
          {
            amount: 1,
            receiver: 'ion',
            sender: 'ion2'
          },
          {
            amount: 2,
            receiver: 'ion',
            sender: 'ion3'
          },
          {
            amount: 1,
            receiver: 'ion',
            sender: 'ion2'
          },
          {
            amount: 2,
            receiver: 'ion',
            sender: 'ion3'
          },
          {
            amount: 1,
            receiver: 'ion',
            sender: 'ion2'
          },
          {
            amount: 2,
            receiver: 'ion',
            sender: 'ion3'
          },
          {
            amount: 1,
            receiver: 'ion',
            sender: 'ion2'
          },
          {
            amount: 2,
            receiver: 'ion',
            sender: 'ion3'
          },
        ]
      },
      {
        hash: 'hash2',
        timestamp: 13333,
        nonce: 1,
        previousHash: 'hash1',
        transactions: [
          {
            amount: 1,
            receiver: 'ion',
            sender: 'ion2'
          },
          {
            amount: 2,
            receiver: 'ion',
            sender: 'ion3'
          },
          {
            amount: 1,
            receiver: 'ion',
            sender: 'ion2'
          },
          {
            amount: 2,
            receiver: 'ion',
            sender: 'ion3'
          },
          {
            amount: 1,
            receiver: 'ion',
            sender: 'ion2'
          },
          {
            amount: 2,
            receiver: 'ion',
            sender: 'ion3'
          },
          {
            amount: 1,
            receiver: 'ion',
            sender: 'ion2'
          },
          {
            amount: 2,
            receiver: 'ion',
            sender: 'ion3'
          },
        ]
      },
      {
        hash: 'hash2',
        timestamp: 13333,
        nonce: 1,
        previousHash: 'hash1',
        transactions: [
          {
            amount: 1,
            receiver: 'ion',
            sender: 'ion2'
          },
          {
            amount: 2,
            receiver: 'ion',
            sender: 'ion3'
          },
          {
            amount: 1,
            receiver: 'ion',
            sender: 'ion2'
          },
          {
            amount: 2,
            receiver: 'ion',
            sender: 'ion3'
          },
          {
            amount: 1,
            receiver: 'ion',
            sender: 'ion2'
          },
          {
            amount: 2,
            receiver: 'ion',
            sender: 'ion3'
          },
          {
            amount: 1,
            receiver: 'ion',
            sender: 'ion2'
          },
          {
            amount: 2,
            receiver: 'ion',
            sender: 'ion3'
          },
        ]
      },
      {
        hash: 'hash2',
        timestamp: 13333,
        nonce: 1,
        previousHash: 'hash1',
        transactions: [
          {
            amount: 1,
            receiver: 'ion',
            sender: 'ion2'
          },
          {
            amount: 2,
            receiver: 'ion',
            sender: 'ion3'
          },
          {
            amount: 1,
            receiver: 'ion',
            sender: 'ion2'
          },
          {
            amount: 2,
            receiver: 'ion',
            sender: 'ion3'
          },
          {
            amount: 1,
            receiver: 'ion',
            sender: 'ion2'
          },
          {
            amount: 2,
            receiver: 'ion',
            sender: 'ion3'
          },
          {
            amount: 1,
            receiver: 'ion',
            sender: 'ion2'
          },
          {
            amount: 2,
            receiver: 'ion',
            sender: 'ion3'
          },
        ]
      },
      {
        hash: 'hash2',
        timestamp: 13333,
        nonce: 1,
        previousHash: 'hash1',
        transactions: [
          {
            amount: 1,
            receiver: 'ion',
            sender: 'ion2'
          },
          {
            amount: 2,
            receiver: 'ion',
            sender: 'ion3'
          },
          {
            amount: 1,
            receiver: 'ion',
            sender: 'ion2'
          },
          {
            amount: 2,
            receiver: 'ion',
            sender: 'ion3'
          },
          {
            amount: 1,
            receiver: 'ion',
            sender: 'ion2'
          },
          {
            amount: 2,
            receiver: 'ion',
            sender: 'ion3'
          },
          {
            amount: 1,
            receiver: 'ion',
            sender: 'ion2'
          },
          {
            amount: 2,
            receiver: 'ion',
            sender: 'ion3'
          },
        ]
      },
      {
        hash: 'hash2',
        timestamp: 13333,
        nonce: 1,
        previousHash: 'hash1',
        transactions: [
          {
            amount: 1,
            receiver: 'ion',
            sender: 'ion2'
          },
          {
            amount: 2,
            receiver: 'ion',
            sender: 'ion3'
          },
          {
            amount: 1,
            receiver: 'ion',
            sender: 'ion2'
          },
          {
            amount: 2,
            receiver: 'ion',
            sender: 'ion3'
          },
          {
            amount: 1,
            receiver: 'ion',
            sender: 'ion2'
          },
          {
            amount: 2,
            receiver: 'ion',
            sender: 'ion3'
          },
          {
            amount: 1,
            receiver: 'ion',
            sender: 'ion2'
          },
          {
            amount: 2,
            receiver: 'ion',
            sender: 'ion3'
          },
        ]
      },
    ];
  }

  ngOnInit() {
  }

}
