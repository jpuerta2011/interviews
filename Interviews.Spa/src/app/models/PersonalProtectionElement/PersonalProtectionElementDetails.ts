import { AuditableTypeIdentifiableModel } from '../base/AuditableTypeIdentifiableModel';

export class PersonalProtectionElementDetails extends AuditableTypeIdentifiableModel {
    description: string;
    positionId: number;
    positionName: string;
    personalProtectionElementId: number;
    personalProtectionElementTypeId: number;
    personalProtectionElementTypeName: string;
    constructor() {
        super();
    }

}
