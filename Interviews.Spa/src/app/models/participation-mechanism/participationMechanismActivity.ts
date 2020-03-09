import { AuditableTypeIdentifiableModel } from '../base/AuditableTypeIdentifiableModel';

export class ParticipationMechanismActivity extends AuditableTypeIdentifiableModel {
    description: String;
    date: Date;
    participationMechanismId: Number;
    organizationId: Number;    
    constructor() {
        super();
    }

}
