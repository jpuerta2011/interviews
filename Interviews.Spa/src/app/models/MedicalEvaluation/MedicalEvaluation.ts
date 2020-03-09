import { MedicalEvaluationDetail } from './MedicalEvaluationDetail';

export class MedicalEvaluation{
    id?: number;
    identityNumber: String;
    name: String;
    email: String;
    phoneNumber: String;
    medicalEntity: String;
    medicalEntityAddress: String;
    description: String;
    scheduleDate: Date;
    positionId: number;
    medicalEvaluationSubTypeId: number;
    medicalEvaluationDetails: MedicalEvaluationDetail[];
    /**
     *
     */
    constructor() {

    }
}
