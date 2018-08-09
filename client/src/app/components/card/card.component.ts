import { Component, OnInit, Input } from '@angular/core';
import { AppService } from '../../app.service';

@Component({
  selector: 'card',
  templateUrl: 'card.component.html',
  styleUrls: ['card.component.scss']
})

export class CardComponent implements OnInit {
  
  @Input() FoodList: Array<Food>;

  constructor(private appService: AppService) { }

  ngOnInit() { }

  public AddStart(FoodId){
    this.appService.AddFoodStar(FoodId);
  }

}