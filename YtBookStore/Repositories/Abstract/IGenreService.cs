﻿
﻿using YtBookStore.Models.Domain;

namespace YtBookStore.Repositories.Abstract

    //in abstract all these are interfaces and in implementation all are classes
{
    public interface IGenreService
    {
        bool Add(Genre model);
        bool Update(Genre model);
        bool Delete(int id);
        Genre FindById(int id);
        IEnumerable<Genre> GetAll();
    }
}

