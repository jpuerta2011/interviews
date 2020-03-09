import { EnvironmentMeasureResult } from './environmentMeasureResult';
import { EnvironmentMeasureBiomechanicalParam } from 'app/models/environment-measure/environmentMeasureBiomechanicalParam';
import { AuditableTypeIdentifiableModel } from '../base/AuditableTypeIdentifiableModel';

export class EnvironmentMeasureBiomechanical  extends AuditableTypeIdentifiableModel{   
    conclusion: String;
    isAcceptable: boolean;
    userId: number;
    fullName: string;
    identityNumber: string;
    paramsList: EnvironmentMeasureBiomechanicalParam[];
    environmentMeasureResult: EnvironmentMeasureResult;

    constructor(){
        super();
    }
}
