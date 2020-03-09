import { AuditableTypeIdentifiableModel } from '../base/AuditableTypeIdentifiableModel';


export class EnvironmentMeasureResult extends AuditableTypeIdentifiableModel {
    date: Date;
    organizationId: number;
    organizationOfficeId: number;
    organizationOfficeName: string;    
    environmentMeasureId: number;
    environmentMeasureTypeId: number;
    environmentMeasureTypeName: string;   
    status: boolean;

    constructor(){
        super();
    }

}
