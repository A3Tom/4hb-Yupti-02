import { ICard } from "./Card";

export interface IGrouping {
  id: number;
  boardId: number;
  title: string;
  description: string;
  labels: string;
  archived: boolean;
  completed: boolean;
  cards: ICard[]
}
