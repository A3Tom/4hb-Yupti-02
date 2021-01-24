import { IGrouping } from "./Grouping";

export interface IBoard {
  id: number;
  name: string;
  description: string;
  active: boolean;
  groupings: IGrouping[];
}
