import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BoardListComponent } from './board-list/board-list.component';
import { GroupingListComponent } from './grouping-list/grouping-list.component';
import { CardsListComponent } from './cards-list/cards-list.component';
import { BoardAllDataViewComponent } from './board-all-data-view/board-all-data-view.component';
import { WorklogsComponent } from './worklogs/worklogs.component';
import { PlanningService } from './planning.service';
import { HttpClientModule } from '@angular/common/http'

@NgModule({
  declarations: [
    AppComponent,
    BoardListComponent,
    GroupingListComponent,
    CardsListComponent,
    BoardAllDataViewComponent,
    WorklogsComponent,
  ],
  imports: [BrowserModule, AppRoutingModule, HttpClientModule],
  providers: [PlanningService],
  bootstrap: [AppComponent],
})
export class AppModule {}
