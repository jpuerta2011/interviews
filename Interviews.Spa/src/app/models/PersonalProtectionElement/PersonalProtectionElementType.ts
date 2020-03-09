import { AuditableTypeIdentifiableModel } from '../base/AuditableTypeIdentifiableModel';

export class PersonalProtectionElementType extends AuditableTypeIdentifiableModel {
    name: string;
    description: string;
    rules: number;
    factSheetBlobId: number;
    imageBlobId: number;
    constructor() {
        super();
    }

}
