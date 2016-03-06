/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   ft_list_last.c                                     :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: mmashego <marvin@42.fr>                    +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2016/02/17 15:09:14 by mmashego          #+#    #+#             */
/*   Updated: 2016/02/17 15:13:34 by mmashego         ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#include "ft_list.h"

t_list		*ft_list_last(t_list *begin_list)
{
			t_list		*list;
			
			list = begin_list;
			if (list)
			{
				while (list->next)
						list = list->next;
				return (list);
			}
			return (NULL);
}
