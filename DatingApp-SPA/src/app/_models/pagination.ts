export interface Pagination {
    currentPage: Number;
    itemsPerPage: Number;
    totalItems: number;
    totalPages: number;
}

export class PaginatedResult<T> {
    result: T;
    pagination: Pagination;
}
