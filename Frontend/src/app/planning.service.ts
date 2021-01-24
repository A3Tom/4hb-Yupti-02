import { Injectable } from '@angular/core';
import { HttpClient, HttpClientModule } from '@angular/common/http';
import { Observable } from 'rxjs';
import { IBoard } from './models/board';

@Injectable({
  providedIn: 'root'
})
export class PlanningService {

  constructor(private http: HttpClient) {

   }
   private planningUrl: string = "https://localhost:44349/Planner/"
   
    getBoards(): Observable<IBoard[]> {
      let url = `${this.planningUrl}GetAllBoards`;
      return this.http.get<IBoard[]>(url);
    } 
}
