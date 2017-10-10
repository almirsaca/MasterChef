import { Injectable } from '@angular/core';
import 'rxjs/add/operator/map'
import { BaseService } from '../services/baseService';

@Injectable()
export class CategoriaService extends BaseService {
    constructor() {
        super()
    }
}
