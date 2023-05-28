import { BaseModel } from './base.model';

export interface RequestModel extends BaseModel {
    Name?: string;
    Email?: string;
    Description?: string;
}