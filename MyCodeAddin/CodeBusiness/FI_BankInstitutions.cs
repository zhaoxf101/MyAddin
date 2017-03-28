using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_BankInstitutions))]
#if Dev
    [RunLocal]
#endif

	public class FI_BankInstitutions:ReadOnlyBase<FI_BankInstitutions>
    {
        #region Business Methods

		
        public string BankInstitutionsCode
        {
            get ;
            set ;
        }

		
        public string BankInstitutionsName
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static FI_BankInstitutions Create()
        {
            return EF.DataPortal.Create<FI_BankInstitutions>();
        }

		public static FI_BankInstitutions Fetch(System.Linq.Expressions.Expression<Func<FI_BankInstitutions, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_BankInstitutions>(exp,values);
            return EF.DataPortal.Fetch<FI_BankInstitutions>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_BankInstitutionss))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_BankInstitutionss:ReadOnlyListBase<FI_BankInstitutionss,FI_BankInstitutions>
    {
        #region Factory Methods

        public static FI_BankInstitutionss Fetch()
        {
            return EF.DataPortal.Fetch<FI_BankInstitutionss>();
        }

		public static FI_BankInstitutionss Fetch(System.Linq.Expressions.Expression<Func<FI_BankInstitutions, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_BankInstitutions>(exp,values);
            return EF.DataPortal.Fetch<FI_BankInstitutionss>(lambda);
		}

		public static FI_BankInstitutionss Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_BankInstitutionss>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_BankInstitutionss Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_BankInstitutions, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_BankInstitutionss>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_BankInstitutions>(exp,values)});
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
