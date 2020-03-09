import {environment} from '../../environments/environment';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';

@Injectable()
export class UploadService {

    constructor(
        private _httpClient: HttpClient,        
    ){}

}