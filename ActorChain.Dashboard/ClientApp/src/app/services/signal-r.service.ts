import { Injectable } from '@angular/core';
import * as signalR from '@aspnet/signalr';

@Injectable({
  providedIn: 'root'
})
export class SignalRService {
  private hubConnection: signalR.HubConnection;

  public startConnection = async () => {
    this.hubConnection = new signalR.HubConnectionBuilder()
      .withUrl('/data')
      .build();

    await this.hubConnection
      .start();
    console.log('Connection started');
    // .catch(err => console.log('Error while starting connection: ' + err));
  }

  public addTransferChartDataListener = () => {
    this.hubConnection.on('transferTransactions', (data) => {
      console.log(data);
    });
  }

  public addTransferBlockChainListener = () => {
    this.hubConnection.on('transferBlockChain', (data) => {
      console.log(data);
    });
  }

  public fetchData = () => {
    this.hubConnection.invoke('getData');
  }
}
