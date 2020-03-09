export class TrainingPlan {
    id: number;
    description: string;
    organizationId: number;
    organizationOfficeId: number;
    createdBy: number;
    createdUserName: string;
    createdDate: Date;
    updatedBy: number;
    updatedUserName: string;
    updatedDate: Date;
    isEnabled: boolean;
}