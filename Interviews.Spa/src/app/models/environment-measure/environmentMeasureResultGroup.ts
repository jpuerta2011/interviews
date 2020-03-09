import { AuditableTypeIdentifiableModel } from '../base/AuditableTypeIdentifiableModel';
import { EnvironmentMeasureResult } from 'app/models/environment-measure/environmentMeasureResult';
import { User } from 'app/models/user/User';

export class EnvironmentMeasureResultGroup extends AuditableTypeIdentifiableModel {
    resultFrom: Number;
    resultTo: Number;
    result: Number;
    measureUnit: String;
    location: String;
    isAcceptable: boolean;
    userList: User[];
    environmentMeasureResult: EnvironmentMeasureResult;

    constructor(){
        super();
    }
}
