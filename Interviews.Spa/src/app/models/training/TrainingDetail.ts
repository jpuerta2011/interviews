import { User } from "../user/User";

export class TrainingDetail {
    id: number;
    trainingTypeId: number;
    trainingTypeDescription: string;
    trainingPlanId: number;
    trainingModalityId: number;
    trainingModalityDescription: string;
    place: string;
    startDate: Date;
    startHour: String;
    trainerName: string;
    trainerId: number;
    duration: number;
    goal: number;
    approval:number;
    trainingStateId: number;
    trainingStateDescription: string;
    guests: User[];
    topic: string;
    content: string;
}