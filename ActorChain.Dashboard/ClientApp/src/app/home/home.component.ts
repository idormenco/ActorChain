import { SignalRService } from './../services/signal-r.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent implements OnInit {
  async ngOnInit(): Promise<void> {
    await this._dataService.startConnection();
    this._dataService.addTransferChartDataListener();
    this._dataService.fetchData();
  }

  constructor(private _dataService: SignalRService) {
  }
}
