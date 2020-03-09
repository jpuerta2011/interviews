import { AuditableTypeIdentifiableModel } from '../base/AuditableTypeIdentifiableModel';
import { PersonalProtectionElementDetails } from './PersonalProtectionElementDetails';

export class PersonalProtectionElement extends AuditableTypeIdentifiableModel {
    description: string;
    organizationOfficeId: number;
    organizationOfficeName: string;
    dateStart: number;
    dateEnd: number;
    positionList: PersonalProtectionElementDetails[];
    constructor() {
        super();
    }

}
