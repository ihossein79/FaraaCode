﻿using CodeTo.Core.Statics;
using CodeTo.Core.ViewModel.Articles;
using CodeTo.DataEF.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using X.PagedList;

namespace CodeTo.Core.Services.ArticleServices.ClientArticleServices
{
    public class ClientArticleService : IClientArticleService
    {
        private readonly CodeToContext _context;

        public ClientArticleService(CodeToContext context)
        {
            _context = context;
        }

        public async Task<IPagedList<ClientArticleViewModel>> GetAllToShowAsync(int pageId = 1, string FilterTitle = "")
        {
            if (pageId <= 0) pageId = 1;
            IEnumerable<ClientArticleViewModel> result;
            result = _context.Articles.ToClientArticleViewModel();

            if (!string.IsNullOrEmpty(FilterTitle))
            {
                result = result.Where(u => u.ArticleTitle.Contains(FilterTitle));
            }

            return result
                .OrderByDescending(u => u.CreateDate)
                .ToPagedList(pageId, Values.BlogPageSize);
        }

        public async Task<ClientArticleViewModel> GetDetailArticle(long id)
        {
            var model = await _context.Articles.FirstOrDefaultAsync(a => a.Id == id);
              return model.ToClientArticleViewModel();
        }
    }
}