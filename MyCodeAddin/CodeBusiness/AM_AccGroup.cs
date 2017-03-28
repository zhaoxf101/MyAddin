using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(AM_AccGroup))]
#if Dev
    [RunLocal]
#endif

	public class AM_AccGroup:ReadOnlyBase<AM_AccGroup>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string AccGroup
        {
            get ;
            set ;
        }

		
        public string DText
        {
            get ;
            set ;
        }

		
        public string DAccCode
        {
            get ;
            set ;
        }

		
        public string CAccCode
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static AM_AccGroup Create()
        {
            return EF.DataPortal.Create<AM_AccGroup>();
        }

		public static AM_AccGroup Fetch(System.Linq.Expressions.Expression<Func<AM_AccGroup, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<AM_AccGroup>(exp,values);
            return EF.DataPortal.Fetch<AM_AccGroup>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(AM_AccGroups))]
#if Dev
    [RunLocal]
#endif
	
	public class AM_AccGroups:ReadOnlyListBase<AM_AccGroups,AM_AccGroup>
    {
        #region Factory Methods

        public static AM_AccGroups Fetch()
        {
            return EF.DataPortal.Fetch<AM_AccGroups>();
        }

		public static AM_AccGroups Fetch(System.Linq.Expressions.Expression<Func<AM_AccGroup, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<AM_AccGroup>(exp,values);
            return EF.DataPortal.Fetch<AM_AccGroups>(lambda);
		}

		public static AM_AccGroups Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<AM_AccGroups>(new Paging { Page=page,RowCount=rowCount});
        }

        public static AM_AccGroups Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<AM_AccGroup, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<AM_AccGroups>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<AM_AccGroup>(exp,values)});
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
