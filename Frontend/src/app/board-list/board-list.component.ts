import { Component, OnInit } from '@angular/core';
import { IBoard } from '../models/board';
import { PlanningService } from '../planning.service';

@Component({
  selector: 'app-board-list',
  templateUrl: './board-list.component.html',
  styleUrls: ['./board-list.component.css']
})
export class BoardListComponent implements OnInit {

  constructor(private planningService: PlanningService) { }

  boards: IBoard[] = [];

  ngOnInit(): void {
    this.callService();
  }

  callService() {
    console.log("callin service !");
    
    let serviceSubscription = this.planningService.getBoards().subscribe(res => console.log(res));
  }

}
