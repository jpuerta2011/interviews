import { HttpInterceptor, HttpRequest, HttpHandler, HttpEvent, HttpErrorResponse } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { tap } from 'rxjs/operators';
import { Router } from '@angular/router';

@Injectable()
export class CustomHttpInterceptor implements HttpInterceptor{

    constructor(private router: Router) {}

    intercept(request: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>>{

        const currentUser: any = JSON.parse(localStorage.getItem('currentUser'));

        if (currentUser && currentUser.loginToken) {
            request = request.clone({
                setHeaders: {
                    Authorization :  `Bearer ${currentUser.loginToken}`
                }
            }); 
        }

        if (!request.headers.has('Content-Type')) {
            request = request.clone({
                headers: request.headers.set('Content-Type', 'application/json')
            });
        }

        return next.handle(request).pipe(
            tap((event: HttpEvent<any>) => {

        }, (err: any) => {
            if (err instanceof HttpErrorResponse) {
                if (err.status === 401) {
                    this.router.navigate(['/auth/login']);
                }
            }
        })
        );
    }
}

