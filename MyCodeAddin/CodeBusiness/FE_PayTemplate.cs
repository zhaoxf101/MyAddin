using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FE_PayTemplate))]
#if Dev
    [RunLocal]
#endif

	public class FE_PayTemplate:ReadOnlyBase<FE_PayTemplate>
    {
        #region Business Methods

		
        public string TCode
        {
            get ;
            set ;
        }

		
        public string TName
        {
            get ;
            set ;
        }

		
        public string LText
        {
            get ;
            set ;
        }

		
        public string AssemblyName
        {
            get ;
            set ;
        }

		
        public string ProgramName
        {
            get ;
            set ;
        }

		
        public string ViewName
        {
            get ;
            set ;
        }

		
        public string CreatedUser
        {
            get ;
            set ;
        }

		
        public DateTime? CreatedDate
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static FE_PayTemplate Create()
        {
            return EF.DataPortal.Create<FE_PayTemplate>();
        }

		public static FE_PayTemplate Fetch(System.Linq.Expressions.Expression<Func<FE_PayTemplate, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FE_PayTemplate>(exp,values);
            return EF.DataPortal.Fetch<FE_PayTemplate>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FE_PayTemplates))]
#if Dev
    [RunLocal]
#endif
	
	public class FE_PayTemplates:ReadOnlyListBase<FE_PayTemplates,FE_PayTemplate>
    {
        #region Factory Methods

        public static FE_PayTemplates Fetch()
        {
            return EF.DataPortal.Fetch<FE_PayTemplates>();
        }

		public static FE_PayTemplates Fetch(System.Linq.Expressions.Expression<Func<FE_PayTemplate, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FE_PayTemplate>(exp,values);
            return EF.DataPortal.Fetch<FE_PayTemplates>(lambda);
		}

		public static FE_PayTemplates Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FE_PayTemplates>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FE_PayTemplates Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FE_PayTemplate, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FE_PayTemplates>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FE_PayTemplate>(exp,values)});
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
