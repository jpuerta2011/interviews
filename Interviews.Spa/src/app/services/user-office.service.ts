import { Injectable } from '@angular/core';
import { GeneralHttpService } from './general-http-service';
import { UserOffice } from 'app/models/user/UserOffice';
import { map } from 'rxjs/operators';

@Injectable()
export class UserOfficeService {


    constructor(
        private _generalHttpService: GeneralHttpService,
    ) 
    { 
    }


    getUserOffices(): any {
        return this._generalHttpService.getAll<UserOffice[]>( `User/5/offices`)
        .pipe(
            map((results: UserOffice[]) => {
                return results;
            })
        );
    }

    setSelectedUserOffice(selectedUserOffice: UserOffice): void{
        localStorage.setItem('seletedUserOffice', JSON.stringify(selectedUserOffice));
    }

    getSelectedUserOffice(): UserOffice {
        const userOffice = new UserOffice();

        if (localStorage.getItem('seletedUserOffice')){
            return JSON.parse(localStorage.getItem('seletedUserOffice'));
        }

        return userOffice;
    }
}
