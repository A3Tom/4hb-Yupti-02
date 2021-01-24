import { Component, OnInit } from '@angular/core';
import { PlanningService } from '../planning.service'

@Component({
  selector: 'app-worklogs',
  templateUrl: './worklogs.component.html',
  styleUrls: ['./worklogs.component.css']
})
export class WorklogsComponent implements OnInit {

  constructor(private planningService: PlanningService) { }

  ngOnInit(): void {
  }

}
