import { IWorklogEvent } from "./WorklogEvent";

export interface ICard {
  id: number;
  groupingId: number;
  title: string;
  description: string;
  labels: string;
  archived: boolean;
  completed: boolean;

  worklogEvents: IWorklogEvent[];
}
