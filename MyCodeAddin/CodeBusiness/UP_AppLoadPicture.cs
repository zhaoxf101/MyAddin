using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(UP_AppLoadPicture))]
#if Dev
    [RunLocal]
#endif

	public class UP_AppLoadPicture:ReadOnlyBase<UP_AppLoadPicture>
    {
        #region Business Methods

		
        public Guid Id
        {
            get ;
            set ;
        }

		
        public string AppKey
        {
            get ;
            set ;
        }

		
        public string ImageType
        {
            get ;
            set ;
        }

		
        public string Version
        {
            get ;
            set ;
        }

		
        public int PIndex
        {
            get ;
            set ;
        }

		
        public string ImageUrl
        {
            get ;
            set ;
        }

		
        public string Introduce
        {
            get ;
            set ;
        }

		
        public string RowStatus
        {
            get ;
            set ;
        }

		
        public string CreateUser
        {
            get ;
            set ;
        }

		
        public DateTime? CreateDate
        {
            get ;
            set ;
        }

		
        public string ChangeUser
        {
            get ;
            set ;
        }

		
        public DateTime? ChangeDate
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static UP_AppLoadPicture Create()
        {
            return EF.DataPortal.Create<UP_AppLoadPicture>();
        }

		public static UP_AppLoadPicture Fetch(System.Linq.Expressions.Expression<Func<UP_AppLoadPicture, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<UP_AppLoadPicture>(exp,values);
            return EF.DataPortal.Fetch<UP_AppLoadPicture>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(UP_AppLoadPictures))]
#if Dev
    [RunLocal]
#endif
	
	public class UP_AppLoadPictures:ReadOnlyListBase<UP_AppLoadPictures,UP_AppLoadPicture>
    {
        #region Factory Methods

        public static UP_AppLoadPictures Fetch()
        {
            return EF.DataPortal.Fetch<UP_AppLoadPictures>();
        }

		public static UP_AppLoadPictures Fetch(System.Linq.Expressions.Expression<Func<UP_AppLoadPicture, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<UP_AppLoadPicture>(exp,values);
            return EF.DataPortal.Fetch<UP_AppLoadPictures>(lambda);
		}

		public static UP_AppLoadPictures Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<UP_AppLoadPictures>(new Paging { Page=page,RowCount=rowCount});
        }

        public static UP_AppLoadPictures Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<UP_AppLoadPicture, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<UP_AppLoadPictures>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<UP_AppLoadPicture>(exp,values)});
        }

        #endregion

		[Serializable]
        public class Paging
        {
            public int Page { get; set; }
            public int RowCount { get; set; }
            public int StartIndex
            {
                get 
                {
                    if (Page >= 0 && RowCount > 0)
                    {
                        return Page * RowCount;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        [Serializable]
        public class PagigExpress
        {
            public int Page { get; set; }
            public int RowCount { get; set; }
            public int StartIndex
            {
                get
                {
                    if (Page >= 0 && RowCount > 0)
                    {
                        return Page * RowCount;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
            public LambdaExpression Lambda { get; set; }
        }

    }
}
