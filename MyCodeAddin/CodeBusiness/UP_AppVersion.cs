using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(UP_AppVersion))]
#if Dev
    [RunLocal]
#endif

	public class UP_AppVersion:ReadOnlyBase<UP_AppVersion>
    {
        #region Business Methods

		
        public Guid Id
        {
            get ;
            set ;
        }

		
        public string AppCode
        {
            get ;
            set ;
        }

		
        public string AppName
        {
            get ;
            set ;
        }

		
        public string AppType
        {
            get ;
            set ;
        }

		
        public string AppVer
        {
            get ;
            set ;
        }

		
        public string AppPath
        {
            get ;
            set ;
        }

		
        public string UpgradeContent
        {
            get ;
            set ;
        }

		
        public bool IsForce
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

		public static UP_AppVersion Create()
        {
            return EF.DataPortal.Create<UP_AppVersion>();
        }

		public static UP_AppVersion Fetch(System.Linq.Expressions.Expression<Func<UP_AppVersion, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<UP_AppVersion>(exp,values);
            return EF.DataPortal.Fetch<UP_AppVersion>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(UP_AppVersions))]
#if Dev
    [RunLocal]
#endif
	
	public class UP_AppVersions:ReadOnlyListBase<UP_AppVersions,UP_AppVersion>
    {
        #region Factory Methods

        public static UP_AppVersions Fetch()
        {
            return EF.DataPortal.Fetch<UP_AppVersions>();
        }

		public static UP_AppVersions Fetch(System.Linq.Expressions.Expression<Func<UP_AppVersion, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<UP_AppVersion>(exp,values);
            return EF.DataPortal.Fetch<UP_AppVersions>(lambda);
		}

		public static UP_AppVersions Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<UP_AppVersions>(new Paging { Page=page,RowCount=rowCount});
        }

        public static UP_AppVersions Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<UP_AppVersion, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<UP_AppVersions>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<UP_AppVersion>(exp,values)});
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
