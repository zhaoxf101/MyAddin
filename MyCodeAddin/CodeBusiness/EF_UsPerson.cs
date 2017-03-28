using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(EF_UsPerson))]
#if Dev
    [RunLocal]
#endif

	public class EF_UsPerson:ReadOnlyBase<EF_UsPerson>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string BName
        {
            get ;
            set ;
        }

		
        public string PersonId
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static EF_UsPerson Create()
        {
            return EF.DataPortal.Create<EF_UsPerson>();
        }

		public static EF_UsPerson Fetch(System.Linq.Expressions.Expression<Func<EF_UsPerson, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<EF_UsPerson>(exp,values);
            return EF.DataPortal.Fetch<EF_UsPerson>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(EF_UsPersons))]
#if Dev
    [RunLocal]
#endif
	
	public class EF_UsPersons:ReadOnlyListBase<EF_UsPersons,EF_UsPerson>
    {
        #region Factory Methods

        public static EF_UsPersons Fetch()
        {
            return EF.DataPortal.Fetch<EF_UsPersons>();
        }

		public static EF_UsPersons Fetch(System.Linq.Expressions.Expression<Func<EF_UsPerson, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<EF_UsPerson>(exp,values);
            return EF.DataPortal.Fetch<EF_UsPersons>(lambda);
		}

		public static EF_UsPersons Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<EF_UsPersons>(new Paging { Page=page,RowCount=rowCount});
        }

        public static EF_UsPersons Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<EF_UsPerson, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<EF_UsPersons>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<EF_UsPerson>(exp,values)});
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
