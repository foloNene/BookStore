using BookStore.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Components
{
    public class SimilarBooks : ViewComponent
    {
        private readonly IBookRepository _bookRepository;

        public SimilarBooks(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task<IViewComponentResult> InvokeAsync(int count)
        {
            var books = await _bookRepository.GetSimilarBooksAsync(count);
            return View(books);
        }

    }
}
