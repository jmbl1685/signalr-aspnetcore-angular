import { Component, OnInit } from '@angular/core';
import { AppService } from './app.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit {

  title = 'app';
  FoodList: Array<Food> = [];

  constructor(private appService: AppService) {
    this.GetFoodList();
  }

  public ngOnInit() {

    this.appService.InitializeConnection()
      .subscribe(
        res => {
          console.log(res);
        },
        err => {
          console.error(err);
        });

      this.appService.HubConnection().on("FoodStar", res => {
        this.FoodList[res.index] = res.food;
      })

  }

  public async GetFoodList() {
    const response = await this.appService.GetFoodList();
    this.FoodList = response;
  }

}
