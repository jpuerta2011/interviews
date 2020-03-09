import { AuditableTypeIdentifiableModel } from "../base/AuditableTypeIdentifiableModel";

export class ProcessModel extends AuditableTypeIdentifiableModel{
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