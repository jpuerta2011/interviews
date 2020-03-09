import { BudgetDetail } from './budgetDetail';

export class Budget {
    id: number;    
    status: boolean; 
    description: string;
    total: number;
    details: BudgetDetail[];
    
    createdDate: Date;
    constructor() {

    }
}
