import { AuditableTypeIdentifiableModel } from '../base/AuditableTypeIdentifiableModel';
import {EnvironmentMeasureType} from './environmentMeasureType';
import { OrganizationOffice } from '../OrganizationOffice/OrganizationOffice';

export class EnvironmentMeasure extends AuditableTypeIdentifiableModel {
    date: Date;
    organizationId: Number;
    typeList: EnvironmentMeasureType[];
    officeList: OrganizationOffice[];

      constructor() {
        super();
    }

}
