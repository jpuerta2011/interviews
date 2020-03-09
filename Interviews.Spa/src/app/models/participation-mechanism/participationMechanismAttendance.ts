import { AuditableTypeIdentifiableModel } from '../base/AuditableTypeIdentifiableModel';

export class ParticipationMechanismAttendance extends AuditableTypeIdentifiableModel {
    userId: Number;    
    userName: String;
    constructor() {
        super();
    }

}
