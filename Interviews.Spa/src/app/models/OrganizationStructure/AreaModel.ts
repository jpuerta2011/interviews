import { AuditableTypeIdentifiableModel } from "../base/AuditableTypeIdentifiableModel";

export class AreaModel extends AuditableTypeIdentifiableModel{
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