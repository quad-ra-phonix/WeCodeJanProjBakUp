/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   ft_stock_par.h                                     :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: mmashego <marvin@42.fr>                    +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2016/02/12 12:22:50 by mmashego          #+#    #+#             */
/*   Updated: 2016/02/12 12:35:54 by mmashego         ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#ifndef __FT_STOCK_PAR_H__
#define __FT_STOCK_PAR_H__

typedef struct s_stock_par
{
	int size_param;
	char *str;
	char *copy;
	char **tab;
}	t_stock_par;

struct s_stock_par *ft_param_to_tab(int ac, char **av);
int ft_strLen(char *str);

#endif
