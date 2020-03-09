import { ParticipationMechanismActivity } from './participationMechanismActivity';
import { AuditableTypeIdentifiableModel } from '../base/AuditableTypeIdentifiableModel';
import { ParticipationMechanismAttendance } from './participationMechanismAttendance';

export class ParticipationMechanism extends AuditableTypeIdentifiableModel {
    name: String;
    topic: String;
    participationMechanismTypeId: Number;
    communicationPlanId: Number;
    organizationId: Number;
    activities: ParticipationMechanismActivity[];
    attenders: ParticipationMechanismAttendance[];

    constructor() {
        super();
    }

}
