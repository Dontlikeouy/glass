USE [glass]
GO

	SELECT view_orderitem.idorder,view_modelcalc.good_marking,sum(view_orderitem.qu*view_modelcalc.qustore) FROM view_orders	

	JOIN view_orderitem on view_orders.idorder=view_orderitem.idorder
	
	JOIN view_modelcalc on view_orderitem.idorderitem=view_modelcalc.idorderitem

	WHERE view_orders.seller_name='Иванов' AND view_orderitem.name='Окно'

	GROUP BY view_orderitem.idorder,view_modelcalc.good_marking

	ORDER BY view_orderitem.idorder ASC
GO