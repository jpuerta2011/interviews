import { AuditableTypeIdentifiableModel } from '../base/AuditableTypeIdentifiableModel';

export class EnvironmentMeasureBiomechanicalParam extends AuditableTypeIdentifiableModel{
    organizationId: number;
    environmentMeasureBiomechanicalId: number;
    environmentMeasureBiomechanicalParamId: number;    
    environmentMeasureBiomechanicalParamDescription: string;
    result: string;
    isAcceptable: boolean;
    comments: string;   
    constructor(){
        super();
    }

}
