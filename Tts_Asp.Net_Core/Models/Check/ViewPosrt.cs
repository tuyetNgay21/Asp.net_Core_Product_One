using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tts_Asp.Net_Core.Models.ConnectDataBase;

namespace Tts_Asp.Net_Core.Models.Check
{
    public static class ViewPosrt
    {
        public static int idSearchSave = 0;
        public static int numberSearchSave = 0;
        public static string contentSearchSave = null;

        public static List<IsPost> DepTrai(int idSearch, int numberSearch, string contentSearch )
        {
            TTS_ASP_CoreContext db = new TTS_ASP_CoreContext();
            var listTheme = db.IsPost.ToList();
            if (idSearchSave != 0 || numberSearchSave != 0 || contentSearchSave != null)
            {
                idSearch = idSearchSave;
                numberSearch = numberSearchSave;
                contentSearch = contentSearchSave;
                if (idSearch != 0)
                {
                    if (idSearch == 1)
                    {
                        listTheme = listTheme.OrderByDescending(m => m.DayInPost).ToList();
                    }
                    else if (idSearch == 2)
                    {
                        listTheme = listTheme.OrderByDescending(m => m.ViewPost).ToList();
                    }
                    else if (idSearch == 3)
                    {
                        listTheme = listTheme.Where(m => m.Deleted == false).ToList();
                    }
                    else if (idSearch == 4)
                    {
                        listTheme = listTheme.Where(m => m.Deleted == true).ToList();
                    }
                    else
                    {
                    }
                }
                else if (numberSearch != 0)
                {
                    listTheme = listTheme.Where(m => m.SpeciesId == numberSearch).ToList();
                }
                else if (contentSearch != null)
                {
                    listTheme = listTheme.Where(oh => oh.Title.Contains(contentSearch)).ToList();
                }
            }
            else
            {
                if (idSearch != 0)
                {
                    if (idSearch == 1)
                    {
                        listTheme = listTheme.OrderByDescending(m => m.DayInPost).ToList();
                    }
                    else if (idSearch == 2)
                    {
                        listTheme = listTheme.OrderByDescending(m => m.ViewPost).ToList();
                    }
                    else if (idSearch == 3)
                    {
                        listTheme = listTheme.Where(m => m.Deleted == false).ToList();
                    }
                    else if (idSearch == 4)
                    {
                        listTheme = listTheme.Where(m => m.Deleted == true).ToList();
                    }
                    else
                    {
                    }
                }
                else if (numberSearch != 0)
                {
                    listTheme = listTheme.Where(m => m.SpeciesId == numberSearch).ToList();
                }
                else if (contentSearch != null)
                {
                    listTheme = listTheme.Where(oh => oh.Title.Contains(contentSearch)).ToList();
                }
                idSearchSave = idSearch;
                numberSearchSave = numberSearch;
                contentSearchSave = contentSearch;
            }
            return listTheme;
        }
    }
}
