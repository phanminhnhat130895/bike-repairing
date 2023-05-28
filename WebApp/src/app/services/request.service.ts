import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { createRequestUrl } from '../common/const';
import { RequestModel } from '../models/request.model';
import { environment } from 'src/environments/environment.development';

@Injectable()
export class RequestService {
    constructor(private httpClient: HttpClient) {}

    OnCreateRequest(request: RequestModel) : Observable<RequestModel>{
        return this.httpClient.post<RequestModel>(environment.apiUrl + createRequestUrl, request);
    }
}