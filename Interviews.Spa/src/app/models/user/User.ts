export class User {
    id: number;
    userName: string;
    password: string;
    firstName: string;
    lastName: string;
    fullName: string;
    token: string;
    middleName: string;
    lastLoginDateTime: Date;
    email: string;
    organizationId: number;
    roleId: number;
    subscriptionId: number;
    packageId: number;
    isActive: boolean;
    isEnabled: boolean;
    isAvatarUploaded: boolean;
    loginAttempts: number;
    identityTypeId: number;
    identityNumber: string;
    countryId: number;
}
