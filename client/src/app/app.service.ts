import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { HubConnection, HubConnectionBuilder } from '@aspnet/signalr';
import { Observable, Observer } from 'rxjs';

@Injectable()
export class AppService {

  private hubConnection: HubConnection;
  private url: string = "https://aspnetcore-api.herokuapp.com";

  constructor(private http: HttpClient) {
    this.hubConnection = new HubConnectionBuilder()
    .withUrl(`${this.url}/FoodHub`)
    .build();
  }

  public HubConnection(): HubConnection{
    return this.hubConnection;
  }

  public AddFoodStar(foodId){
    this.hubConnection.invoke('AddFoodStar', foodId).catch(err => console.log(err))
  }

  public InitializeConnection(): Observable<boolean> {

    return Observable.create((observer: Observer<boolean>) => {
      this.hubConnection
        .start()
        .then(() => {
          console.log('Hub connection started');
          observer.next(true);
          observer.complete();
        })
        .catch(err => {
          console.log('Error while establishing connection', err);
          observer.error(err);
        });
    });
  }

  public GetFoodList(): Promise<any> {
    return this.http.get(`${this.url}/api/food`).toPromise();
  }

}