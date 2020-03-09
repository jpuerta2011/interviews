import { AuditableTypeIdentifiableModel } from "../base/AuditableTypeIdentifiableModel";

export class OrganizationOffice extends AuditableTypeIdentifiableModel{
    name: String;
    address: String;
    telephone: String;
    contactName: String;
    email: String;
    /**
     *
     */
    constructor() {
        super();
    }
}
