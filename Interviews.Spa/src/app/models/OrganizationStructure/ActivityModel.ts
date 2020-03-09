import { AuditableTypeIdentifiableModel } from "../base/AuditableTypeIdentifiableModel";

export class ActivityModel extends AuditableTypeIdentifiableModel{
    description: string;
    organizationId: number;
    isEnabled: boolean;
    /**
     *
     */
    constructor() {
        super();
    }
}