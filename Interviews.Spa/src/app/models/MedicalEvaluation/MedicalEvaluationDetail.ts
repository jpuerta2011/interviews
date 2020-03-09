import { MedicalEvaluationSubType } from './MedicalEvaluationSubType';

export class MedicalEvaluationDetail{
    id?: number;
    appointmentDate: Date;
    appointmentTime: String;
    medicalEvaluationPrice: number;
    medicalEvaluationSubType?: MedicalEvaluationSubType;
    medicalEvaluationSubTypeId: number;
    medicalEvaluationSubTypeName: String;
    updated?: boolean;
    new?: boolean;
    deleted?: boolean;
    isFinalized?: boolean;
    medicalAssessmentValue?: number;
    comments?: String;
    /**
     *
     */
    constructor() {

    }
}
