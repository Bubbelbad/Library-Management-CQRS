﻿
namespace Application.Dtos.BookCopyDtos
{
    public class AddBookCopyDto
    {
        public Guid BookId { get; set; }
        public int BranchId { get; set; }
        public string? Status { get; set; }
    }
}
