USE [glass]
GO


	SELECT view_orderitem.idorder,view_modelcalc.good_marking, Sum(view_modelcalc.qustore * view_orderitem.qu) FROM view_modelcalc	

	JOIN view_orderitem ON view_orderitem.idorderitem=view_modelcalc.idorderitem

	GROUP BY view_orderitem.idorder, view_modelcalc.good_marking

	ORDER BY view_orderitem.idorder ASC 
GO