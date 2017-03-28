using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(PM_ModProjIncDet))]
#if Dev
    [RunLocal]
#endif

	public class PM_ModProjIncDet:ReadOnlyBase<PM_ModProjIncDet>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string ProjCode
        {
            get ;
            set ;
        }

		
        public string IncDetCode
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static PM_ModProjIncDet Create()
        {
            return EF.DataPortal.Create<PM_ModProjIncDet>();
        }

		public static PM_ModProjIncDet Fetch(System.Linq.Expressions.Expression<Func<PM_ModProjIncDet, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<PM_ModProjIncDet>(exp,values);
            return EF.DataPortal.Fetch<PM_ModProjIncDet>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(PM_ModProjIncDets))]
#if Dev
    [RunLocal]
#endif
	
	public class PM_ModProjIncDets:ReadOnlyListBase<PM_ModProjIncDets,PM_ModProjIncDet>
    {
        #region Factory Methods

        public static PM_ModProjIncDets Fetch()
        {
            return EF.DataPortal.Fetch<PM_ModProjIncDets>();
        }

		public static PM_ModProjIncDets Fetch(System.Linq.Expressions.Expression<Func<PM_ModProjIncDet, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<PM_ModProjIncDet>(exp,values);
            return EF.DataPortal.Fetch<PM_ModProjIncDets>(lambda);
		}

		public static PM_ModProjIncDets Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<PM_ModProjIncDets>(new Paging { Page=page,RowCount=rowCount});
        }

        public static PM_ModProjIncDets Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<PM_ModProjIncDet, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<PM_ModProjIncDets>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<PM_ModProjIncDet>(exp,values)});
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
