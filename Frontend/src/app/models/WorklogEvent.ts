export interface IWorklogEvent {
  id: number;
  cardId: number;
  workStart: Date;
  workEnd: string;
  finalFurlong: boolean;
  createdOn: Date;
}
