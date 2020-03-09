import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { map } from 'rxjs/operators';
import {environment} from '../../environments/environment';


@Injectable()
export class AuthenticationService {
    endPoint = 'https://localhost:44309/api/';


    constructor(private _httpClient: HttpClient){ }

    login(username: string, password: string): any {

        return this._httpClient.post<any>(`${environment.apiBaseUrl}Login/Authenticate`,
        { username, password})
        .pipe(
            map(( user => {
                if (user) {
                    localStorage.setItem('currentUser', JSON.stringify(user));
                }

                return user;
            }))
        );
    }

    
}
